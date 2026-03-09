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
    /// Choice of formats for the specification of other identification.
    /// </summary>
    [KnownType(typeof(OtherIdentification4Choice.Code))]
    [KnownType(typeof(OtherIdentification4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OtherIdentification4Choice.Code),nameof(OtherIdentification4Choice.Code))]
    [JsonDerivedType(typeof(OtherIdentification4Choice.Proprietary),nameof(OtherIdentification4Choice.Proprietary))]
    #endif
    [IsoId("_S_Cxr0HLEeWeNKJ6kJGSFw")]
    [DisplayName("Other Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OtherIdentification4Choice_
    #else
    public abstract partial class OtherIdentification4Choice_
    #endif
    {
    }
}
