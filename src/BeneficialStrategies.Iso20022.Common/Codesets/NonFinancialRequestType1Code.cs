// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a6o5MC_rEeugIJ3Gvoevmg")]
[Description(
    @"Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer."
)]
[DerivedFrom(typeof(NonFinancialRequestTypeCode))]
public enum NonFinancialRequestType1Code
{
    /// <summary>
    /// According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_hzPIsS_rEeugIJ3Gvoevmg")]
    [Description(
        @"According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction."
    )]
    AcquirerSelection = NonFinancialRequestTypeCode.AcquirerSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;PARQ&quot;.
    /// </summary>
    [EnumMember(Value = "PARQ")]
    [IsoId("_h4cY0S_rEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction."
    )]
    ParRequest = NonFinancialRequestTypeCode.ParRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_h8-TgS_rEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction."
    )]
    RiskManagement = NonFinancialRequestTypeCode.RiskManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Intermediary Agent or Acquirer provides the token to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_iB8TES_rEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer provides the token to use to process the transaction."
    )]
    TokenRequest = NonFinancialRequestTypeCode.TokenRequest, // same ordinal as derivation source for type conversions
}
