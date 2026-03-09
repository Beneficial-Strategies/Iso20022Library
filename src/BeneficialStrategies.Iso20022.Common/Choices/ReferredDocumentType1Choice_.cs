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
    [KnownType(typeof(ReferredDocumentType1Choice.Code))]
    [KnownType(typeof(ReferredDocumentType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReferredDocumentType1Choice.Code),nameof(ReferredDocumentType1Choice.Code))]
    [JsonDerivedType(typeof(ReferredDocumentType1Choice.Proprietary),nameof(ReferredDocumentType1Choice.Proprietary))]
    #endif
    [IsoId("_T3sBRdp-Ed-ak6NoX_4Aeg_174928116")]
    [DisplayName("Referred Document Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReferredDocumentType1Choice_
    #else
    public abstract partial class ReferredDocumentType1Choice_
    #endif
    {
    }
}
