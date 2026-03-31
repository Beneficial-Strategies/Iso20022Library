// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DefinedAttributes1Choice
{
    /// <summary>
    /// Shares or some other fixed amount of derivative (such an ERIS future or swaption), or a fixed quantity of commodities.
    /// </summary>
    [IsoId("__F7tMOPJEea7_eMQH225xA")]
    [DisplayName("Quantity Defined Attributes")]
    [IsoXmlTag("QtyDfndAttrbts")]
    public record QuantityDefinedAttributes : DefinedAttributes1Choice_
    {
        /// <summary>
        /// Quantity of product defined in the contract.
        /// </summary>
        [IsoId("_lvercMhjEeadgvwNGwK05w")]
        [DisplayName("Contract Size")]
        [IsoXmlTag("CtrctSz")]
        public required ContractSize1 ContractSize { get; init; }

        /// <summary>
        /// Indicates whether the contract is cash/physical/optional settled.
        /// </summary>
        [IsoId("_ZPUhEMhkEeadgvwNGwK05w")]
        [DisplayName("Delivery Type")]
        [IsoXmlTag("DlvryTp")]
        public required PhysicalTransferType4Code DeliveryType { get; init; }

        /// <summary>
        /// Unique identifier for underlying or deliverable financial product on which final settlement price or equivalent is calculated.
        /// </summary>
        [IsoId("_dlsEYMhkEeadgvwNGwK05w")]
        [DisplayName("Underlying Identification")]
        [IsoXmlTag("UndrlygId")]
        public required GenericIdentification165 UnderlyingIdentification { get; init; }

        /// <summary>
        /// Specifies the currency of price of underlying.
        /// </summary>
        [IsoId("_0ce18MhkEeadgvwNGwK05w")]
        [DisplayName("Price Currency")]
        [IsoXmlTag("PricCcy")]
        public required ActiveCurrencyCode PriceCurrency { get; init; }
    }
}
