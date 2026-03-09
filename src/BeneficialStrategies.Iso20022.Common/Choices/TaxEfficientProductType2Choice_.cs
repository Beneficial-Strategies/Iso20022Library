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
    /// Choice of formats for a type of tax efficient product.
    /// </summary>
    [KnownType(typeof(TaxEfficientProductType2Choice.Code))]
    [KnownType(typeof(TaxEfficientProductType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxEfficientProductType2Choice.Code),nameof(TaxEfficientProductType2Choice.Code))]
    [JsonDerivedType(typeof(TaxEfficientProductType2Choice.Proprietary),nameof(TaxEfficientProductType2Choice.Proprietary))]
    #endif
    [IsoId("_Ugn1YZNNEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxEfficientProductType2Choice_
    #else
    public abstract partial class TaxEfficientProductType2Choice_
    #endif
    {
    }
}
