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
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration1Choice.Code))]
    [KnownType(typeof(Registration1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Registration1Choice.Code),nameof(Registration1Choice.Code))]
    [JsonDerivedType(typeof(Registration1Choice.Proprietary),nameof(Registration1Choice.Proprietary))]
    #endif
    [IsoId("_QwBFtNp-Ed-ak6NoX_4Aeg_1955517270")]
    [DisplayName("Registration 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Registration1Choice_
    #else
    public abstract partial class Registration1Choice_
    #endif
    {
    }
}
