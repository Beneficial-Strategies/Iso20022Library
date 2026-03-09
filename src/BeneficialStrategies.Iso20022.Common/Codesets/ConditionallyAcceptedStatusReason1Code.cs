// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vjk7Vtp-Ed-ak6NoX_4Aeg_-149220072")]
[Description(@"Specifies the reason for a conditionally accepted status.")]
[DerivedFrom(typeof(ConditionallyAcceptedStatusReasonCode))]
public enum ConditionallyAcceptedStatusReason1Code
{
    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_Vjk7V9p-Ed-ak6NoX_4Aeg_-123362029")]
    [Description(@"Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.")]
    AwaitingMoney = ConditionallyAcceptedStatusReasonCode.AwaitingMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete it.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_Vjk7WNp-Ed-ak6NoX_4Aeg_351329874")]
    [Description(@"Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete it.")]
    AwaitingFunds = ConditionallyAcceptedStatusReasonCode.AwaitingFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_VjusUNp-Ed-ak6NoX_4Aeg_411359154")]
    [Description(@"Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.")]
    AwaitingDocuments = ConditionallyAcceptedStatusReasonCode.AwaitingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another reason for the conditionally accepted status.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VjusUdp-Ed-ak6NoX_4Aeg_-187465798")]
    [Description(@"Another reason for the conditionally accepted status.")]
    Other = ConditionallyAcceptedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
