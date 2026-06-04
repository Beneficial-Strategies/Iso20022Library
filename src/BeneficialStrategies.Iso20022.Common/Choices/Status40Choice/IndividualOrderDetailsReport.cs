// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status40Choice
{
    /// <summary>Status expressed as individual order details report.</summary>
    [IsoId("4d4904e8-05b8-4895-9228-fe87533c6de8")]
    [DisplayName("Individual Order Details Report")]
    public record IndividualOrderDetailsReport : Status40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IndvOrdrDtlsRpt")]
        public required IndividualOrderStatusAndReason9 Value { get; init; }
    }
}
