// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrCurrency1Choice
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_o-ev0lhDEeOMYfRGLS0NbA")]
    [DisplayName("Depository")]
    public record Depository : PartyOrCurrency1Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_HUH4QUiQEeOdL6nMHefDgg")]
        [DisplayName("Party Identification")]
        [IsoXmlTag("PtyId")]
        public required PartyIdentification75Choice_ PartyIdentification { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_HUH4RUiQEeOdL6nMHefDgg")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; }
    }
}
