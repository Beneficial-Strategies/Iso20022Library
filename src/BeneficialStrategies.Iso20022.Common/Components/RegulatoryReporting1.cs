// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes data elements that can be used for reporting to trade repositories, it is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular confirmations.
/// </summary>
[IsoId("_SEtVEyi-EeKnA5P_jl2DUw")]
[DisplayName("Regulatory Reporting")]
public record RegulatoryReporting1
{
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_koKpMCi-EeKnA5P_jl2DUw")]
    [DisplayName("Reporting Jurisdiction")]
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportingJurisdiction { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_pU-WkCi-EeKnA5P_jl2DUw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public PartyIdentification73Choice_? ReportingParty { get; init; }

    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI).This is the UTI from the Trading Side party.
    /// </summary>
    [IsoId("_Nqo4moKGEeKmtdhZXgREOQ")]
    [DisplayName("Trading Side Unique Transaction Identifier")]
    [IsoXmlTag("TradgSdUnqTxIdr")]
    public UniqueTransactionIdentifier1? TradingSideUniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI).This is the UTI from the Counterparty Side party.
    /// </summary>
    [IsoId("_o3u8CoKGEeKmtdhZXgREOQ")]
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    public UniqueTransactionIdentifier1? CounterpartySideUniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    [IsoId("_Bd_McC46EeK7-OZOLIksSw")]
    [DisplayName("Clearing Exception Party")]
    [IsoXmlTag("ClrXcptnPty")]
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; }

    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    [IsoId("_v1MUUC46EeK7-OZOLIksSw")]
    [DisplayName("Clearing Broker Identification")]
    [IsoXmlTag("ClrBrkrId")]
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; }

    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    [IsoId("_01RIsC5KEeK7-OZOLIksSw")]
    [DisplayName("Clearing Threshold Indicator")]
    [IsoXmlTag("ClrThrshldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; }

    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_iYdM8C47EeK7-OZOLIksSw")]
    [DisplayName("Cleared Product Identification")]
    [IsoXmlTag("ClrdPdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearedProductIdentification { get; init; }

    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_NFyc0CjmEeK1Sbo8NpBROA")]
    [DisplayName("Underlying Product Identifier")]
    [IsoXmlTag("UndrlygPdctIdr")]
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; }

    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_OevXUCjnEeK1Sbo8NpBROA")]
    [DisplayName("Allocation Indicator")]
    [IsoXmlTag("AllcnInd")]
    public AllocationIndicator1Code? AllocationIndicator { get; init; }

    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    [IsoId("_6c0vcC48EeK7-OZOLIksSw")]
    [DisplayName("Collateralisation Indicator")]
    [IsoXmlTag("CollstnInd")]
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; }

    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    [IsoId("_luDhICjoEeK1Sbo8NpBROA")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExecutionVenue { get; init; }

    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    [IsoId("_tj7RMCjoEeK1Sbo8NpBROA")]
    [DisplayName("Execution Timestamp")]
    [IsoXmlTag("ExctnTmstmp")]
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; }

    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    [IsoId("_MnF0kC5KEeK7-OZOLIksSw")]
    [DisplayName("Non Standard Flag")]
    [IsoXmlTag("NonStdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonStandardFlag { get; init; }

    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    [IsoId("_U_yssCjrEeK1Sbo8NpBROA")]
    [DisplayName("Link Swap Identification")]
    [IsoXmlTag("LkSwpId")]
    [IsoSimpleType(IsoSimpleType.Exact42Text)]
    public IsoExact42Text? LinkSwapIdentification { get; init; }

    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    [IsoId("_ZGe_0CjsEeK1Sbo8NpBROA")]
    [DisplayName("Additional Reporting Information")]
    [IsoXmlTag("AddtlRptgInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReportingInformation { get; init; }
}
