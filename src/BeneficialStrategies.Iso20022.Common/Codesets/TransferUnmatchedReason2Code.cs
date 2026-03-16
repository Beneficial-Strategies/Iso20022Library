// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction unmatched status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yvk9RNp-Ed-ak6NoX_4Aeg_1536774987")]
[Description(@"Specifies the reason for a transfer or settlement instruction unmatched status.")]
[DerivedFrom(typeof(TransferUnmatchedReasonCode))]
public enum TransferUnmatchedReason2Code
{
    /// <summary>
    /// No potential match has been found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Yvk9Rdp-Ed-ak6NoX_4Aeg_1880322038")]
    [Description(@"No potential match has been found.")]
    NoMatch = TransferUnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Yvk9Rtp-Ed-ak6NoX_4Aeg_1880322073")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelled = TransferUnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of transaction does not match: delivery instead of receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Yvk9R9p-Ed-ak6NoX_4Aeg_1880322133")]
    [Description(
        @"Direction of transaction does not match: delivery instead of receipt or vice versa."
    )]
    TransactionDirection = TransferUnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_YvuHMNp-Ed-ak6NoX_4Aeg_1880322393")]
    [Description(
        @"Financial instrument identification does not match or a financial instrument attribute differs."
    )]
    FinancialInstrument = TransferUnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement does not match: counterparty&apos;s instruction is for physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_YvuHMdp-Ed-ak6NoX_4Aeg_1880322471")]
    [Description(
        @"Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = TransferUnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched: it is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_YvuHMtp-Ed-ak6NoX_4Aeg_1880322524")]
    [Description(@"Instruction has not been matched: it is a possible duplicate instruction.")]
    Duplicate = TransferUnmatchedReasonCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_YvuHM9p-Ed-ak6NoX_4Aeg_1880322566")]
    [Description(@"Place of settlement does not match.")]
    SettlementPlace = TransferUnmatchedReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date or transfer date does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_YvuHNNp-Ed-ak6NoX_4Aeg_1880322874")]
    [Description(@"Settlement date or transfer date does not match.")]
    SettlementDate = TransferUnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_YvuHNdp-Ed-ak6NoX_4Aeg_1880322927")]
    [Description(@"Financial instrument quantity does not match.")]
    FinancialInstrumentQuantity = TransferUnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
}
