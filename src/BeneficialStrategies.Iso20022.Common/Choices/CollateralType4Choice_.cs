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
    /// Choice of format for the collateral type.
    /// </summary>
    [KnownType(typeof(CollateralType4Choice.Code))]
    [KnownType(typeof(CollateralType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralType4Choice.Code),nameof(CollateralType4Choice.Code))]
    [JsonDerivedType(typeof(CollateralType4Choice.Proprietary),nameof(CollateralType4Choice.Proprietary))]
    #endif
    [IsoId("_DjSkgZEkEeakHoV5BVecAQ")]
    [DisplayName("Collateral Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralType4Choice_
    #else
    public abstract partial class CollateralType4Choice_
    #endif
    {
    }
}
