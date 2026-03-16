// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeLegNotificationIdentification1Choice
{
    /// <summary>
    /// Trade Leg Notification Identification.
    /// </summary>
    [DisplayName("Trade Leg Notification Identification")]
    public partial record TradeLegNotificationIdentification : TradeLegNotificationIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TradLegNtfctnId")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
