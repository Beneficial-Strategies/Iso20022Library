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
    /// Choice of format for the model form identification.
    /// </summary>
    [KnownType(typeof(ModelFormIdentification1Choice.Code))]
    [KnownType(typeof(ModelFormIdentification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModelFormIdentification1Choice.Code),nameof(ModelFormIdentification1Choice.Code))]
    [JsonDerivedType(typeof(ModelFormIdentification1Choice.Proprietary),nameof(ModelFormIdentification1Choice.Proprietary))]
    #endif
    [IsoId("_929T03ltEeG7BsjMvd1mEw_-115804936")]
    [DisplayName("Model Form Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModelFormIdentification1Choice_
    #else
    public abstract partial class ModelFormIdentification1Choice_
    #endif
    {
    }
}
