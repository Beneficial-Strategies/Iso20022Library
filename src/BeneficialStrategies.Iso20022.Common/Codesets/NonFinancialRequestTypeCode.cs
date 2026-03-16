// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HCEBsC_qEeugIJ3Gvoevmg")]
[Description(
    @"Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer."
)]
[Derivations(typeof(NonFinancialRequestType1Code), typeof(NonFinancialRequestType2Code))]
public enum NonFinancialRequestTypeCode
{
    /// <summary>
    /// According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_aagdEC_qEeugIJ3Gvoevmg")]
    [Description(
        @"According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction."
    )]
    AcquirerSelection,

    /// <summary>
    /// The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_uMxGoC_qEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction."
    )]
    RiskManagement,

    /// <summary>
    /// The Intermediary Agent or Acquirer provides the token to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_Kq8-gC_rEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer provides the token to use to process the transaction."
    )]
    TokenRequest,

    /// <summary>
    /// The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;PARQ&quot;.
    /// </summary>
    [EnumMember(Value = "PARQ")]
    [IsoId("_Tp0-AC_rEeugIJ3Gvoevmg")]
    [Description(
        @"The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction."
    )]
    ParRequest,

    /// <summary>
    /// Request to receive acquirer instalment plans.
    /// Encoded/decoded by serializers as &quot;INSM&quot;.
    /// </summary>
    [EnumMember(Value = "INSM")]
    [IsoId("_4VqPsHC6Ee2bmOA3bkVsMg")]
    [Description(@"Request to receive acquirer instalment plans.")]
    InstalmentPlanRequest,

    /// <summary>
    /// Indicates a request which implies to receive additional information.
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_8T9RQHC6Ee2bmOA3bkVsMg")]
    [Description(@"Indicates a request which implies to receive additional information.")]
    AdditionalRequest,
}
