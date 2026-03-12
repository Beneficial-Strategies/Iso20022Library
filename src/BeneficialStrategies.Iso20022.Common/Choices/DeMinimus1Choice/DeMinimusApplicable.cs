// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeMinimus1Choice
{
    /// <summary>
    /// Conditions applicable when the investor is covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_CgNiAggqEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus Applicable")]
    public partial record DeMinimusApplicable : DeMinimus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates whether the investor permits its beneficial owners that are restricted persons, if any, to participate in profits and losses allocated to the investor that are attribute to new issue securities.
        /// </summary>
        [IsoId("_RSSsUdp-Ed-ak6NoX_4Aeg_-1045122513")]
        [DisplayName("New Issue Permission")]
        [IsoXmlTag("NewIssePrmssn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator NewIssuePermission { get; init; } 
        
        /// <summary>
        /// Percentage of the new issue profits and losses that it receives to beneficial owners that are restricted persons.
        /// </summary>
        [IsoId("_RSSsUtp-Ed-ak6NoX_4Aeg_-1042351920")]
        [DisplayName("Percentage")]
        [IsoXmlTag("Pctg")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? Percentage { get; init; } 
        
        
        #nullable disable
        
    }
}
