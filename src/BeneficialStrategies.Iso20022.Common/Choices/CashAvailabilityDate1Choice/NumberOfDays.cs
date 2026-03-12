// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAvailabilityDate1Choice
{
    /// <summary>
    /// Indicates the number of float days attached to the balance.
    /// </summary>
    [IsoId("_VnGekzqwEeWZFYSPlduMhw")]
    [DisplayName("Number Of Days")]
    public partial record NumberOfDays : CashAvailabilityDate1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 15 digits and may be prefixed with a plus sign.
        /// </summary>
        [IsoXmlTag("NbOfDays")]
        [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
        public required IsoMax15PlusSignedNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
