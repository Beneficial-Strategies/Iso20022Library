// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_ZoITsSSBEeWWV-wpfEW00A")]
[DisplayName("Deliver Information")]
public record DeliverInformation17
{
    /// <summary>
    /// Party that delivers (transferor) securities to the receiving agent (transferee).
    /// </summary>
    [IsoId("_Gg_9gyU4EeWI0orciOKunQ")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public PartyIdentification70Choice_? Transferor { get; init; }

    /// <summary>
    /// Account from which the securities are to be delivered.
    /// </summary>
    [IsoId("_Gg_9hCU4EeWI0orciOKunQ")]
    [DisplayName("Transferor Registered Account")]
    [IsoXmlTag("TrfrRegdAcct")]
    public Account19? TransferorRegisteredAccount { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Gg_9hSU4EeWI0orciOKunQ")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary34> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aFb6qSSBEeWWV-wpfEW00A")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aFb6qySBEeWWV-wpfEW00A")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_aFb6rSSBEeWWV-wpfEW00A")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_aFb6rySBEeWWV-wpfEW00A")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_aFb6sSSBEeWWV-wpfEW00A")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_aFb6sySBEeWWV-wpfEW00A")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge29> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_aFb6tSSBEeWWV-wpfEW00A")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission23> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_aFb6tySBEeWWV-wpfEW00A")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax28> TaxDetails { get; init; } = [];

    /// <summary>
    /// Specifies foreign exchange details applied to the payment of charges, taxes and commissions as a result of the transfer.
    /// </summary>
    [IsoId("_aFb6uSSBEeWWV-wpfEW00A")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms26> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_aFb6uySBEeWWV-wpfEW00A")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public DeliveringPartiesAndAccount13? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_aFb6vSSBEeWWV-wpfEW00A")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_aFb6vySBEeWWV-wpfEW00A")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_aFb6wSSBEeWWV-wpfEW00A")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference7? ClientReference { get; init; }
}
