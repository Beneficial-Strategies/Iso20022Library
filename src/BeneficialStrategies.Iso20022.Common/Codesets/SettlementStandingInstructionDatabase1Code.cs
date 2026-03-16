// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMMAxtp-Ed-ak6NoX_4Aeg_-1452828987")]
[Description(
    @"Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction."
)]
[DerivedFrom(typeof(SettlementStandingInstructionDatabaseCode))]
public enum SettlementStandingInstructionDatabase1Code
{
    /// <summary>
    /// The settlement standing instruction database to be used is the receiver&apos;s internal database.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZMMAx9p-Ed-ak6NoX_4Aeg_-774171757")]
    [Description(
        @"The settlement standing instruction database to be used is the receiver's internal database."
    )]
    InternalDatabase = SettlementStandingInstructionDatabaseCode.InternalDatabase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The settlement standing instruction database to be used is the broker&apos;s database.
    /// Encoded/decoded by serializers as &quot;BRKR&quot;.
    /// </summary>
    [EnumMember(Value = "BRKR")]
    [IsoId("_ZMVKsNp-Ed-ak6NoX_4Aeg_-371277985")]
    [Description(
        @"The settlement standing instruction database to be used is the broker's database."
    )]
    BrokerDatabase = SettlementStandingInstructionDatabaseCode.BrokerDatabase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The settlement standing instruction database to be used is the database of the vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_ZMVKsdp-Ed-ak6NoX_4Aeg_-1645817532")]
    [Description(
        @"The settlement standing instruction database to be used is the database of the vendor."
    )]
    VendorDatabase = SettlementStandingInstructionDatabaseCode.VendorDatabase, // same ordinal as derivation source for type conversions
}
