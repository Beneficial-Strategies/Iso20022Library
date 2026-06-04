// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status40Choice
{
    /// <summary>Status expressed as switch order details report.</summary>
    [IsoId("0e70bb2b-0724-484d-ac26-d52f1a47d17d")]
    [DisplayName("Switch Order Details Report")]
    public record SwitchOrderDetailsReport : Status40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SwtchOrdrDtlsRpt")]
        public required SwitchOrderStatusAndReason3 Value { get; init; }
    }
}
