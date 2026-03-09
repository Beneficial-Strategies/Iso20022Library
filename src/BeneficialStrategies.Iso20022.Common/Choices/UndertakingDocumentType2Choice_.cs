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
    /// Choice of format for the document type.
    /// </summary>
    [KnownType(typeof(UndertakingDocumentType2Choice.Code))]
    [KnownType(typeof(UndertakingDocumentType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UndertakingDocumentType2Choice.Code),nameof(UndertakingDocumentType2Choice.Code))]
    [JsonDerivedType(typeof(UndertakingDocumentType2Choice.Proprietary),nameof(UndertakingDocumentType2Choice.Proprietary))]
    #endif
    [IsoId("_we6lgDPGEeKaav-uUgD4RA")]
    [DisplayName("Undertaking Document Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UndertakingDocumentType2Choice_
    #else
    public abstract partial class UndertakingDocumentType2Choice_
    #endif
    {
    }
}
