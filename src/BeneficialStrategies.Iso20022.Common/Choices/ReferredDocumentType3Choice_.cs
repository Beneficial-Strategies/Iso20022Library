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
    /// Specifies the type of the document referred in the remittance information.
    /// </summary>
    [KnownType(typeof(ReferredDocumentType3Choice.Code))]
    [KnownType(typeof(ReferredDocumentType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReferredDocumentType3Choice.Code),nameof(ReferredDocumentType3Choice.Code))]
    [JsonDerivedType(typeof(ReferredDocumentType3Choice.Proprietary),nameof(ReferredDocumentType3Choice.Proprietary))]
    #endif
    [IsoId("_XxL1Jx77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReferredDocumentType3Choice_
    #else
    public abstract partial class ReferredDocumentType3Choice_
    #endif
    {
    }
}
