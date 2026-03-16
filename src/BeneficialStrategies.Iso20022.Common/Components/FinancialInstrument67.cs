// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
[IsoId("_BlC7cU4EEeiQHa-q1Uephw")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument67
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_fXwWQ04EEeiQHa-q1Uephw")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_fXwWRE4EEeiQHa-q1Uephw")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument1Choice_ Instrument { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_D3Cj8lTuEeiQFOf5GRHqeQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_D3Cj81TuEeiQFOf5GRHqeQ")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_B1Qhu04EEeiQHa-q1Uephw")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_958R0an8EeitU9ya4obnlw")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account28? Transferor { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_356dcU4EEeiQHa-q1Uephw")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters13? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_gr1KcXVaEeiiHo4Gse0d2w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
