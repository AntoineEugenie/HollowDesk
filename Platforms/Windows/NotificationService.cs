using System;
using Microsoft.Maui.ApplicationModel;

namespace HollowDesk.Platforms.Windows
{
    public static class NotificationService
    {
        public static void AfficherToast(string titre, string message)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    string toastXml = $@"
                        <toast>
                            <visual>
                                <binding template='ToastGeneric'>
                                    <text>{titre}</text>
                                    <text>{message}</text>
                                </binding>
                            </visual>
                        </toast>";

                    var xmlDoc = new global::Windows.Data.Xml.Dom.XmlDocument();
                    xmlDoc.LoadXml(toastXml);

                    // 1. Création de la notification
                    var toast = new global::Windows.UI.Notifications.ToastNotification(xmlDoc);

                    // 2. Utiliser l'Id de package de ton appli MAUI pour rassurer Windows
                    string appId = global::Windows.ApplicationModel.Package.Current.Id.FamilyName;

                    // 3. On passe l'appId au manager
                    global::Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier(appId).Show(toast);
                }
                catch (Exception toastEx)
                {
                    // Si ça plante ici, regarde la fenêtre "Sortie" (Output) de Visual Studio
                    System.Diagnostics.Debug.WriteLine($"[ERREUR TOAST] : {toastEx.Message}");
                }
            });
        }
    }
}