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
    /// Choice of format for the delivery return information.
    /// </summary>
    [KnownType(typeof(DeliveryReturn1Choice.Code))]
    [KnownType(typeof(DeliveryReturn1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeliveryReturn1Choice.Code),nameof(DeliveryReturn1Choice.Code))]
    [JsonDerivedType(typeof(DeliveryReturn1Choice.Proprietary),nameof(DeliveryReturn1Choice.Proprietary))]
    #endif
    [IsoId("_QuOV89p-Ed-ak6NoX_4Aeg_1305476197")]
    [DisplayName("Delivery Return 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeliveryReturn1Choice_
    #else
    public abstract partial class DeliveryReturn1Choice_
    #endif
    {
    }
}
