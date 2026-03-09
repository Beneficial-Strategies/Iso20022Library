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
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [KnownType(typeof(QuantityNominalValue2Choice.Quantity))]
    [KnownType(typeof(QuantityNominalValue2Choice.NominalValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(QuantityNominalValue2Choice.Quantity),nameof(QuantityNominalValue2Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityNominalValue2Choice.NominalValue),nameof(QuantityNominalValue2Choice.NominalValue))]
    #endif
    [IsoId("_byObccpbEem6kd3Y9uIDqg")]
    [DisplayName("Quantity Nominal Value 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityNominalValue2Choice_
    #else
    public abstract partial class QuantityNominalValue2Choice_
    #endif
    {
    }
}
