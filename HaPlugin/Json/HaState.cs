﻿namespace Loupedeck.HomeAssistant.Json
{
    using System;

    using Newtonsoft.Json.Linq;

    public class HaState
    {
        public String Entity_Id { get; set; }

        public String State { get; set; }

        public JObject Attributes { get; set; }

        public String FriendlyName => this.Attributes.ContainsKey("friendly_name") ? this.Attributes.Value<String>("friendly_name") : "";

        public String Icon => this.Attributes.ContainsKey("icon") ? this.Attributes.Value<String>("icon") : "";

        public override String ToString() => this.Entity_Id + " // " + this.State + " // " + this.Attributes;

        public static HaState FromString(String jsonState) => JsonHelpers.DeserializeAnyObject<HaState>(jsonState);
    }
}
