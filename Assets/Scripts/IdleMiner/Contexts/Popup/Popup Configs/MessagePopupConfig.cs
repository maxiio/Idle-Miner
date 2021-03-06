﻿using PG.Core.Contexts.Popup;
using PG.IdleMiner.view.popup.popupresult;

namespace PG.IdleMiner.view.popup.popupconfig
{
    public class MessagePopupConfig : PopupConfig
    {
        public static IPopupConfig GetMessagePopupConfig(string title, string message)
        {
            // @todo - MS - Localization.
            return PopulatedConfigInstance(new MessagePopupConfig(), title, message, "Ok");
        }


        public override IPopupResult GetPopupResult()
        {
            return new MessagePopupResult();
        }
    }
}