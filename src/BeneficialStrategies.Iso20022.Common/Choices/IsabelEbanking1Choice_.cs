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
    /// Specifies the choice of identification of the e-banking application as a contract or a user identification.
    /// </summary>
    [KnownType(typeof(IsabelEbanking1Choice.UserIdentification))]
    [KnownType(typeof(IsabelEbanking1Choice.ContractIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IsabelEbanking1Choice.UserIdentification),nameof(IsabelEbanking1Choice.UserIdentification))]
    [JsonDerivedType(typeof(IsabelEbanking1Choice.ContractIdentification),nameof(IsabelEbanking1Choice.ContractIdentification))]
    #endif
    [IsoId("_F5NoEKA3EeWiJt5KdX5iuQ")]
    [DisplayName("Isabel Ebanking 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IsabelEbanking1Choice_
    #else
    public abstract partial class IsabelEbanking1Choice_
    #endif
    {
    }
}
