// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the equity financial instruments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hrceQAjsEeW36pGcc5RpFw")]
[Description(@"Specifies the equity financial instruments.")]
[DerivedFrom(typeof(FinancialInstrumentReportingClassificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EquityInstrumentReportingClassification1Code>))]
#endif
public enum EquityInstrumentReportingClassification1Code
{
    /// <summary>
    /// Contract is of type shares.
    /// Encoded/decoded by serializers as &quot;SHRS&quot;.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_DpNkQQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type shares.")]
    Share = FinancialInstrumentReportingClassificationCode.Share, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract is of type other equity-like financial instrument.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DxPe4QjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type other equity-like financial instrument.")]
    Other = FinancialInstrumentReportingClassificationCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract is of type electronic traded funds.
    /// Encoded/decoded by serializers as &quot;ETFS&quot;.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_D4hyoQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type electronic traded funds.")]
    ElectronicTradedFund = FinancialInstrumentReportingClassificationCode.ElectronicTradedFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract is of type depositary receipt.
    /// Encoded/decoded by serializers as &quot;DPRS&quot;.
    /// </summary>
    [EnumMember(Value = "DPRS")]
    [IsoId("_EFnzcQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type depositary receipt.")]
    DepositaryReceipt = FinancialInstrumentReportingClassificationCode.DepositaryReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract is of type certificates.
    /// Encoded/decoded by serializers as &quot;CRFT&quot;.
    /// </summary>
    [EnumMember(Value = "CRFT")]
    [IsoId("_EO2A4QjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type certificates.")]
    Certificate = FinancialInstrumentReportingClassificationCode.Certificate, // same ordinal as derivation source for type conversions
}
