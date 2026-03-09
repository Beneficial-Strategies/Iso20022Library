// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bA3DYdp-Ed-ak6NoX_4Aeg_-1241620271")]
[Description(@"Specifies the reason for a conditionally accepted status.")]
[DerivedFrom(typeof(ConditionallyAcceptedStatusReasonCode))]
public enum ConditionallyAcceptedStatusReason2Code
{
    /// <summary>
    /// Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_bA3DYtp-Ed-ak6NoX_4Aeg_-883291302")]
    [Description(@"Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.")]
    AwaitingDocuments = ConditionallyAcceptedStatusReasonCode.AwaitingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete the redemption.
    /// Encoded/decoded by serializers as &quot;AWRM&quot;.
    /// </summary>
    [EnumMember(Value = "AWRM")]
    [IsoId("_bA3DY9p-Ed-ak6NoX_4Aeg_-1558528706")]
    [Description(@"Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete the redemption.")]
    AwaitingRedemptionMoney = ConditionallyAcceptedStatusReasonCode.AwaitingRedemptionMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.
    /// Encoded/decoded by serializers as &quot;AWSM&quot;.
    /// </summary>
    [EnumMember(Value = "AWSM")]
    [IsoId("_bA3DZNp-Ed-ak6NoX_4Aeg_-1558528628")]
    [Description(@"Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.")]
    AwaitingSubscriptionMoney = ConditionallyAcceptedStatusReasonCode.AwaitingSubscriptionMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted for further processing pending the result of the investigation for possible duplicates.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bA3DZdp-Ed-ak6NoX_4Aeg_-1290549980")]
    [Description(@"Order is accepted for further processing pending the result of the investigation for possible duplicates.")]
    PossibleDuplicate = ConditionallyAcceptedStatusReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted for further processing pending the extension of the trading limit.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_bA3DZtp-Ed-ak6NoX_4Aeg_-1227752075")]
    [Description(@"Order is accepted for further processing pending the extension of the trading limit.")]
    TradingLimitExceeded = ConditionallyAcceptedStatusReasonCode.TradingLimitExceeded, // same ordinal as derivation source for type conversions
    
}
