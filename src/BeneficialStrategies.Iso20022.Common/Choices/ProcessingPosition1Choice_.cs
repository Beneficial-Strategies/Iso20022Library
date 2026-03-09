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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition1Choice.Code))]
    [KnownType(typeof(ProcessingPosition1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingPosition1Choice.Code),nameof(ProcessingPosition1Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition1Choice.Proprietary),nameof(ProcessingPosition1Choice.Proprietary))]
    #endif
    [IsoId("_QzcNINp-Ed-ak6NoX_4Aeg_135502517")]
    [DisplayName("Processing Position 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition1Choice_
    #else
    public abstract partial class ProcessingPosition1Choice_
    #endif
    {
    }
}
