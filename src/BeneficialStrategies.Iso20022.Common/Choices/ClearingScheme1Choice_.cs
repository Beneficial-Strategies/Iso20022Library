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
    /// Clearing scheme codes related to Registry of the Clearing Positions (RCP).
    /// </summary>
    [KnownType(typeof(ClearingScheme1Choice.Code))]
    [KnownType(typeof(ClearingScheme1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingScheme1Choice.Code),nameof(ClearingScheme1Choice.Code))]
    [JsonDerivedType(typeof(ClearingScheme1Choice.Proprietary),nameof(ClearingScheme1Choice.Proprietary))]
    #endif
    [IsoId("_NDocIAVoEeaubbxOHT6aDQ")]
    [DisplayName("Clearing Scheme 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingScheme1Choice_
    #else
    public abstract partial class ClearingScheme1Choice_
    #endif
    {
    }
}
