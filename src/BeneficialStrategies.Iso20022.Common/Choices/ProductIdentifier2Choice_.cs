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
    /// Identifies a product in coded form or free text.
    /// </summary>
    [KnownType(typeof(ProductIdentifier2Choice.StructuredProductIdentifier))]
    [KnownType(typeof(ProductIdentifier2Choice.OtherProductIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProductIdentifier2Choice.StructuredProductIdentifier),nameof(ProductIdentifier2Choice.StructuredProductIdentifier))]
    [JsonDerivedType(typeof(ProductIdentifier2Choice.OtherProductIdentifier),nameof(ProductIdentifier2Choice.OtherProductIdentifier))]
    #endif
    [IsoId("_Rb1C0Np-Ed-ak6NoX_4Aeg_-1291805290")]
    [DisplayName("Product Identifier 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProductIdentifier2Choice_
    #else
    public abstract partial class ProductIdentifier2Choice_
    #endif
    {
    }
}
