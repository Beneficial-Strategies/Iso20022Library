// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of the collateral account.
    /// </summary>
    [KnownType(typeof(CollateralAccountIdentificationType2Choice.Type))]
    [KnownType(typeof(CollateralAccountIdentificationType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralAccountIdentificationType2Choice.Type),nameof(CollateralAccountIdentificationType2Choice.Type))]
    [JsonDerivedType(typeof(CollateralAccountIdentificationType2Choice.Proprietary),nameof(CollateralAccountIdentificationType2Choice.Proprietary))]
    #endif
    [IsoId("_Y-Lll4FxEeWtPe6Crjmeug")]
    [DisplayName("Collateral Account Identification Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralAccountIdentificationType2Choice_
    #else
    public abstract partial class CollateralAccountIdentificationType2Choice_
    #endif
    {
    }
}
