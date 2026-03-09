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
    /// Modality of counting as a predefined or proprietary code value.
    /// </summary>
    [KnownType(typeof(ModalityOfCounting1Choice.Code))]
    [KnownType(typeof(ModalityOfCounting1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModalityOfCounting1Choice.Code),nameof(ModalityOfCounting1Choice.Code))]
    [JsonDerivedType(typeof(ModalityOfCounting1Choice.Proprietary),nameof(ModalityOfCounting1Choice.Proprietary))]
    #endif
    [IsoId("_ZBJPkK-vEemJ1NnLPsTFaw")]
    [DisplayName("Modality Of Counting 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModalityOfCounting1Choice_
    #else
    public abstract partial class ModalityOfCounting1Choice_
    #endif
    {
    }
}
