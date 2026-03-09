// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of delivery return.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azc5g9p-Ed-ak6NoX_4Aeg_-2045082222")]
[Description(@"Specifies the type of delivery return.")]
[Derivations(typeof(DeliveryReturn1Code))]
public enum DeliveryReturnCode
{
    /// <summary>
    /// Original delivery is not recognized.
    /// Encoded/decoded by serializers as &quot;UNRE&quot;.
    /// </summary>
    [EnumMember(Value = "UNRE")]
    [IsoId("_azc5hNp-Ed-ak6NoX_4Aeg_-2045082220")]
    [Description(@"Original delivery is not recognized.")]
    UnrecognisedDelivery,
    
    /// <summary>
    /// Wrong quantity delivered in the original instruction.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_azc5hdp-Ed-ak6NoX_4Aeg_-2045082197")]
    [Description(@"Wrong quantity delivered in the original instruction.")]
    WrongQuantity,
    
    /// <summary>
    /// Wrong settlement amount settled in the original delivery.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_azc5htp-Ed-ak6NoX_4Aeg_-2045082196")]
    [Description(@"Wrong settlement amount settled in the original delivery.")]
    WrongSettlementAmount,
    
    /// <summary>
    /// Only a portion of the original transaction quantity was delivered by the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_azmDcNp-Ed-ak6NoX_4Aeg_-2045082180")]
    [Description(@"Only a portion of the original transaction quantity was delivered by the Central Securities Depository (CSD).")]
    PartialDelivery,
    
    /// <summary>
    /// Account information is missing in the original delivery.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_azmDcdp-Ed-ak6NoX_4Aeg_-2045082179")]
    [Description(@"Account information is missing in the original delivery.")]
    AccountMissing,
    
    /// <summary>
    /// Due bill information missing in the original delivery.
    /// Encoded/decoded by serializers as &quot;DUEB&quot;.
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_azmDctp-Ed-ak6NoX_4Aeg_-2045082145")]
    [Description(@"Due bill information missing in the original delivery.")]
    DueBiillMissing,
    
    /// <summary>
    /// Portion of the original transaction quantity was returned by the receiver.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_azmDc9p-Ed-ak6NoX_4Aeg_-2045082136")]
    [Description(@"Portion of the original transaction quantity was returned by the receiver.")]
    PartialReturn,
    
}
