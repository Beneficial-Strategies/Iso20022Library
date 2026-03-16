// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party assigning an identification to a customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Pqt-kFyyEeeve7Je9cXtkQ")]
[Description(@"Party assigning an identification to a customer.")]
[DerivedFrom(typeof(CustomerAssignerCode))]
public enum CustomerAssigner1Code
{
    /// <summary>
    /// Legal authority assigning an identification.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_Vb-ykVyyEeeve7Je9cXtkQ")]
    [Description(@"Legal authority assigning an identification.")]
    Authority = CustomerAssignerCode.Authority, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Company assigning an identification to a customer.
    /// Encoded/decoded by serializers as &quot;CRCY&quot;.
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("_Vnk-klyyEeeve7Je9cXtkQ")]
    [Description(@"Company assigning an identification to a customer.")]
    Company = CustomerAssignerCode.Company, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Company for which the customer is on duty.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_V-C90VyyEeeve7Je9cXtkQ")]
    [Description(@"Company for which the customer is on duty.")]
    Customer = CustomerAssignerCode.Customer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On file identification.
    /// Encoded/decoded by serializers as &quot;ONFL&quot;.
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_WMVRclyyEeeve7Je9cXtkQ")]
    [Description(@"On file identification.")]
    OnFile = CustomerAssignerCode.OnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other party assigning an identification.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_WZHwQlyyEeeve7Je9cXtkQ")]
    [Description(@"Other party assigning an identification.")]
    Other = CustomerAssignerCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Travel agency assigning an identification.
    /// Encoded/decoded by serializers as &quot;TRAY&quot;.
    /// </summary>
    [EnumMember(Value = "TRAY")]
    [IsoId("_WkujUlyyEeeve7Je9cXtkQ")]
    [Description(@"Travel agency assigning an identification.")]
    TravelAgency = CustomerAssignerCode.TravelAgency, // same ordinal as derivation source for type conversions
}
