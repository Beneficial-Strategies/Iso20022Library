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
    /// Choice between a document identification provided either by the account owner or by the account servicer.
    /// </summary>
    [KnownType(typeof(DocumentIdentification3Choice.AccountServicerDocumentIdentification))]
    [KnownType(typeof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DocumentIdentification3Choice.AccountServicerDocumentIdentification),nameof(DocumentIdentification3Choice.AccountServicerDocumentIdentification))]
    [JsonDerivedType(typeof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification),nameof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification))]
    #endif
    [IsoId("_E5kPkTnaEeWLJsP1cO-amg")]
    [DisplayName("Document Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentIdentification3Choice_
    #else
    public abstract partial class DocumentIdentification3Choice_
    #endif
    {
    }
}
