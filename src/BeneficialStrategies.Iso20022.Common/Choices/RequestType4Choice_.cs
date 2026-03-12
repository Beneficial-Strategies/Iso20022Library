// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType4Choice.PaymentControl))]
    [KnownType(typeof(RequestType4Choice.Enquiry))]
    [KnownType(typeof(RequestType4Choice.Proprietary))]
    [JsonDerivedType(typeof(RequestType4Choice.PaymentControl),nameof(RequestType4Choice.PaymentControl))]
    [JsonDerivedType(typeof(RequestType4Choice.Enquiry),nameof(RequestType4Choice.Enquiry))]
    [JsonDerivedType(typeof(RequestType4Choice.Proprietary),nameof(RequestType4Choice.Proprietary))]
    [IsoId("_ivV-XZIhEeect698_YsnIA")]
    [DisplayName("Request Type 4 Choice")]
    public abstract partial record RequestType4Choice_
    {
    }
}
