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
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [KnownType(typeof(CollateralFlag13Choice.Collateralised))]
    [KnownType(typeof(CollateralFlag13Choice.Uncollateralised))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralFlag13Choice.Collateralised),nameof(CollateralFlag13Choice.Collateralised))]
    [JsonDerivedType(typeof(CollateralFlag13Choice.Uncollateralised),nameof(CollateralFlag13Choice.Uncollateralised))]
    #endif
    [IsoId("_J9q9scg5Eeu4ecZgAYuz5w")]
    [DisplayName("Collateral Flag 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralFlag13Choice_
    #else
    public abstract partial class CollateralFlag13Choice_
    #endif
    {
    }
}
