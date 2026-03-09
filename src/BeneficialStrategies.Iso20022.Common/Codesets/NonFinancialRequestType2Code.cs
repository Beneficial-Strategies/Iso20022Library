// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbH7sXC8Ee2bmOA3bkVsMg")]
[Description(@"Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.")]
[DerivedFrom(typeof(NonFinancialRequestTypeCode))]
public enum NonFinancialRequestType2Code
{
    /// <summary>
    /// According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_hiZBUXC8Ee2bmOA3bkVsMg")]
    [Description(@"According to several parameters of a transaction, an Intermediary Agent helps an Acceptor to identify the more relevant Acquirer to process the transaction.")]
    AcquirerSelection = NonFinancialRequestTypeCode.AcquirerSelection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;PARQ&quot;.
    /// </summary>
    [EnumMember(Value = "PARQ")]
    [IsoId("_hiZBU3C8Ee2bmOA3bkVsMg")]
    [Description(@"The Intermediary Agent or Acquirer provides the PaymentAccountReference to use to process the transaction.")]
    ParRequest = NonFinancialRequestTypeCode.ParRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_hiZBVXC8Ee2bmOA3bkVsMg")]
    [Description(@"The Intermediary Agent or Acquirer helps the Acceptor to assess the risk management of the transaction.")]
    RiskManagement = NonFinancialRequestTypeCode.RiskManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Intermediary Agent or Acquirer provides the token to use to process the transaction.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_hiZBV3C8Ee2bmOA3bkVsMg")]
    [Description(@"The Intermediary Agent or Acquirer provides the token to use to process the transaction.")]
    TokenRequest = NonFinancialRequestTypeCode.TokenRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a request which implies to receive additional information.
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_mQM0QXC8Ee2bmOA3bkVsMg")]
    [Description(@"Indicates a request which implies to receive additional information.")]
    AdditionalRequest = NonFinancialRequestTypeCode.AdditionalRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to receive acquirer instalment plans.
    /// Encoded/decoded by serializers as &quot;INSM&quot;.
    /// </summary>
    [EnumMember(Value = "INSM")]
    [IsoId("_maVnsXC8Ee2bmOA3bkVsMg")]
    [Description(@"Request to receive acquirer instalment plans.")]
    InstalmentPlanRequest = NonFinancialRequestTypeCode.InstalmentPlanRequest, // same ordinal as derivation source for type conversions
    
}
