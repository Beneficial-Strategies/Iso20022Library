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
[IsoId("_5vuigFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the investigation sub type, as published in an external investigation sub type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationSubTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationSubType1Code>))]
public enum ExternalInvestigationSubType1Code
{
    /// <summary>
    /// Investigation relates to anti-money laundering.
    /// Encoded/decoded by serializers as &quot;AMLI&quot;.
    /// </summary>
    [EnumMember(Value = "AMLI")]
    [IsoId("___Q7GdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to anti-money laundering.")]
    AntiMoneyLaundering = ExternalInvestigationSubTypeCode.AntiMoneyLaundering, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to financial crimes compliance.
    /// Encoded/decoded by serializers as &quot;FCCI&quot;.
    /// </summary>
    [EnumMember(Value = "FCCI")]
    [IsoId("___Q7IdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    FinancialCrimeCompliance = ExternalInvestigationSubTypeCode.FinancialCrimeCompliance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to fraud.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("___Q7HdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to fraud.")]
    Fraud = ExternalInvestigationSubTypeCode.Fraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to funds/wire transfer regulation.
    /// Encoded/decoded by serializers as &quot;FWTR&quot;.
    /// </summary>
    [EnumMember(Value = "FWTR")]
    [IsoId("___Q7I9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds/wire transfer regulation.")]
    FundsWireTransferRegulation = ExternalInvestigationSubTypeCode.FundsWireTransferRegulation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_wPOmYcnxEfCY0M4eFzOwyQ")]
    [Description(@"Other")]
    Other = ExternalInvestigationSubTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relating to charges that have been taken or are requested.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("_q1gvssnxEfCY0M4eFzOwyQ")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    RequestRelatedToCharges = ExternalInvestigationSubTypeCode.RequestRelatedToCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_O8bwAsnxEfCY0M4eFzOwyQ")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation = ExternalInvestigationSubTypeCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("__7fgYsnwEfCY0M4eFzOwyQ")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds = ExternalInvestigationSubTypeCode.RequestUseOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("_g-4o0cnxEfCY0M4eFzOwyQ")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment = ExternalInvestigationSubTypeCode.RequestValueDateAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to sanctions.
    /// Encoded/decoded by serializers as &quot;SANC&quot;.
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("___Q7G9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to sanctions.")]
    Sanctions = ExternalInvestigationSubTypeCode.Sanctions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to a transaction that cannot be executed.
    /// Encoded/decoded by serializers as &quot;UTEX&quot;.
    /// </summary>
    [EnumMember(Value = "UTEX")]
    [IsoId("___Q7H9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to a transaction that cannot be executed.")]
    UnableToExecute = ExternalInvestigationSubTypeCode.UnableToExecute, // same ordinal as derivation source for type conversions
}
