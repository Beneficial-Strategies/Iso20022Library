// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeMinimus1Choice
{
    /// <summary>
    /// Conditions applicable when the investor is not covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_CgNiAwgqEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus Not Applicable")]
    public partial record DeMinimusNotApplicable : DeMinimus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the restricted person.
        /// </summary>
        [IsoId("_RSI7Wdp-Ed-ak6NoX_4Aeg_491616181")]
        [DisplayName("Restricted Person Reason")]
        [IsoXmlTag("RstrctdPrsnRsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text RestrictedPersonReason { get; init; } 
        
        
        #nullable disable
        
    }
}
