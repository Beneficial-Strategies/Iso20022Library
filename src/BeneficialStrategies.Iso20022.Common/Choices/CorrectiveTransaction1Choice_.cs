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
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction1Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction1Choice.Interbank))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorrectiveTransaction1Choice.Initiation),nameof(CorrectiveTransaction1Choice.Initiation))]
    [JsonDerivedType(typeof(CorrectiveTransaction1Choice.Interbank),nameof(CorrectiveTransaction1Choice.Interbank))]
    #endif
    [IsoId("_P7RPB9p-Ed-ak6NoX_4Aeg_445154531")]
    [DisplayName("Corrective Transaction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorrectiveTransaction1Choice_
    #else
    public abstract partial class CorrectiveTransaction1Choice_
    #endif
    {
    }
}
