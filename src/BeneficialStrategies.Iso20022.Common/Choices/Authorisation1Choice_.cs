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
    /// Provides the details on the user identification or any user key that allows to check if the initiating party is allowed to issue the transaction.
    /// </summary>
    [KnownType(typeof(Authorisation1Choice.Code))]
    [KnownType(typeof(Authorisation1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Authorisation1Choice.Code),nameof(Authorisation1Choice.Code))]
    [JsonDerivedType(typeof(Authorisation1Choice.Proprietary),nameof(Authorisation1Choice.Proprietary))]
    #endif
    [IsoId("_RD1Zltp-Ed-ak6NoX_4Aeg_-955120203")]
    [DisplayName("Authorisation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Authorisation1Choice_
    #else
    public abstract partial class Authorisation1Choice_
    #endif
    {
    }
}
