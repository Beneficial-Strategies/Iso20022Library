// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority levels for the BusinessMessage. The different priorities are typically user / service / implementation dependent. The semantics of the different values for a Mesage (Set) need to be defined by the relevant user community (SEG.).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BusinessMessagePriorityCode")]
[Description(
    @"Specifies the priority levels for the BusinessMessage. The different priorities are typically user / service / implementation dependent. The semantics of the different values for a Mesage (Set) need to be defined by the relevant user community (SEG.)."
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<BusinessMessagePriorityCode>))]
public enum BusinessMessagePriorityCode { }
