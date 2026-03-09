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
    /// Choice of format for the type of document format.
    /// </summary>
    [KnownType(typeof(PresentationDocumentFormat1Choice.Code))]
    [KnownType(typeof(PresentationDocumentFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PresentationDocumentFormat1Choice.Code),nameof(PresentationDocumentFormat1Choice.Code))]
    [JsonDerivedType(typeof(PresentationDocumentFormat1Choice.Proprietary),nameof(PresentationDocumentFormat1Choice.Proprietary))]
    #endif
    [IsoId("_94JmoHltEeG7BsjMvd1mEw_1618190567")]
    [DisplayName("Presentation Document Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PresentationDocumentFormat1Choice_
    #else
    public abstract partial class PresentationDocumentFormat1Choice_
    #endif
    {
    }
}
