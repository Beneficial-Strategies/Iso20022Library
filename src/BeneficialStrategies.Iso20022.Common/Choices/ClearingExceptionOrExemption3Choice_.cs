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
    /// Information about contract status.
    /// </summary>
    [KnownType(typeof(ClearingExceptionOrExemption3Choice.Reason))]
    [KnownType(typeof(ClearingExceptionOrExemption3Choice.Counterparties))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingExceptionOrExemption3Choice.Reason),nameof(ClearingExceptionOrExemption3Choice.Reason))]
    [JsonDerivedType(typeof(ClearingExceptionOrExemption3Choice.Counterparties),nameof(ClearingExceptionOrExemption3Choice.Counterparties))]
    #endif
    [IsoId("_Ah8Gl5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Clearing Exception Or Exemption 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingExceptionOrExemption3Choice_
    #else
    public abstract partial class ClearingExceptionOrExemption3Choice_
    #endif
    {
    }
}
