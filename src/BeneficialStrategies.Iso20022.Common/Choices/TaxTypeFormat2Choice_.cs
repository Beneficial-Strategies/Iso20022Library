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
    /// Type of tax expressed in structured or free text form.
    /// </summary>
    [KnownType(typeof(TaxTypeFormat2Choice.Unstructured))]
    [KnownType(typeof(TaxTypeFormat2Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxTypeFormat2Choice.Unstructured),nameof(TaxTypeFormat2Choice.Unstructured))]
    [JsonDerivedType(typeof(TaxTypeFormat2Choice.Structured),nameof(TaxTypeFormat2Choice.Structured))]
    #endif
    [IsoId("_Uy2pBdp-Ed-ak6NoX_4Aeg_2019279092")]
    [DisplayName("Tax Type Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxTypeFormat2Choice_
    #else
    public abstract partial class TaxTypeFormat2Choice_
    #endif
    {
    }
}
