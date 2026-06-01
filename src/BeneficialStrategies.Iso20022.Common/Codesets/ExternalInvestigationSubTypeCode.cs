// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation sub type, as published in an external investigation sub type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W99OIEk8Ee2pGuIgvBXIzg")]
[Description(
    @"Specifies the investigation sub type, as published in an external investigation sub type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationSubType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationSubTypeCode>))]
public enum ExternalInvestigationSubTypeCode
{
    /// <summary>
    /// Investigation relates to anti-money laundering.
    /// Encoded/decoded by serializers as &quot;AMLI&quot;.
    /// </summary>
    [EnumMember(Value = "AMLI")]
    [IsoId("__-YKM9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to anti-money laundering.")]
    AntiMoneyLaundering,

    /// <summary>
    /// Investigation relates to financial crimes compliance.
    /// Encoded/decoded by serializers as &quot;FCCI&quot;.
    /// </summary>
    [EnumMember(Value = "FCCI")]
    [IsoId("__-YKN9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    FinancialCrimeCompliance,

    /// <summary>
    /// Investigation relates to fraud.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("__-YKNdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to fraud.")]
    Fraud,

    /// <summary>
    /// Investigation relates to funds/wire transfer regulation.
    /// Encoded/decoded by serializers as &quot;FWTR&quot;.
    /// </summary>
    [EnumMember(Value = "FWTR")]
    [IsoId("__-YKONYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds/wire transfer regulation.")]
    FundsWireTransferRegulation,

    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_wPN_UMnxEfCY0M4eFzOwyQ")]
    [Description(@"Other")]
    Other,

    /// <summary>
    /// Investigation relating to charges that have been taken or are requested.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("_q1gvsMnxEfCY0M4eFzOwyQ")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    RequestRelatedToCharges,

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_O8bwAMnxEfCY0M4eFzOwyQ")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation,

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("__7fgYMnwEfCY0M4eFzOwyQ")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds,

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("_g-4BwMnxEfCY0M4eFzOwyQ")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment,

    /// <summary>
    /// Investigation relates to sanctions.
    /// Encoded/decoded by serializers as &quot;SANC&quot;.
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("__-YKNNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to sanctions.")]
    Sanctions,

    /// <summary>
    /// Investigation relates to a transaction that cannot be executed.
    /// Encoded/decoded by serializers as &quot;UTEX&quot;.
    /// </summary>
    [EnumMember(Value = "UTEX")]
    [IsoId("__-YKNtYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to a transaction that cannot be executed.")]
    UnableToExecute,
}
