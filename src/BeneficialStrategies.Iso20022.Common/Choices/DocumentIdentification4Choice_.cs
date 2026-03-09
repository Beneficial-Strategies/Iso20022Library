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
    [KnownType(typeof(DocumentIdentification4Choice.AccountServicerDocumentIdentification))]
    [KnownType(typeof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DocumentIdentification4Choice.AccountServicerDocumentIdentification),nameof(DocumentIdentification4Choice.AccountServicerDocumentIdentification))]
    [JsonDerivedType(typeof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification),nameof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification))]
    #endif
    [IsoId("_celQvZKQEeWHWpTQn1FFVg")]
    [DisplayName("Document Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentIdentification4Choice_
    #else
    public abstract partial class DocumentIdentification4Choice_
    #endif
    {
    }
}
