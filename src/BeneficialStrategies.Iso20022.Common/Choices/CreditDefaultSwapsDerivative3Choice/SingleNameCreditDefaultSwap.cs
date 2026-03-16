// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice
{
    /// <summary>
    /// A credit default swap on a single name instrument.
    /// </summary>
    [IsoId("_xfbL0X5eEea2k7EBUopqxw")]
    [DisplayName("Single Name Credit Default Swap")]
    [IsoXmlTag("SnglNmCdtDfltSwp")]
    public record SingleNameCreditDefaultSwap : CreditDefaultSwapsDerivative3Choice_
    {
        /// <summary>
        /// Reference entity of a single name credit default swap (CDS) or a derivative on single name CDS.
        /// </summary>
        [IsoId("_NvBOEX5fEea2k7EBUopqxw")]
        [DisplayName("Sovereign Issuer")]
        [IsoXmlTag("SvrgnIssr")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator SovereignIssuer { get; init; }

        /// <summary>
        /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
        /// </summary>
        [IsoId("_NvBOE35fEea2k7EBUopqxw")]
        [DisplayName("Reference Party")]
        [IsoXmlTag("RefPty")]
        public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; }

        /// <summary>
        /// Currency in which the notional is denominated.
        /// </summary>
        [IsoId("_NvBOFX5fEea2k7EBUopqxw")]
        [DisplayName("Notional Currency")]
        [IsoXmlTag("NtnlCcy")]
        public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; }
    }
}
