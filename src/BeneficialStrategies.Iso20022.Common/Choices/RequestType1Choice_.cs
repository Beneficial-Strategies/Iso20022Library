// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType1Choice.PaymentControl))]
    [KnownType(typeof(RequestType1Choice.Enquiry))]
    [JsonDerivedType(typeof(RequestType1Choice.PaymentControl),nameof(RequestType1Choice.PaymentControl))]
    [JsonDerivedType(typeof(RequestType1Choice.Enquiry),nameof(RequestType1Choice.Enquiry))]
    [IsoId("_RZlnJtp-Ed-ak6NoX_4Aeg_-764921074")]
    [DisplayName("Request Type 1 Choice")]
    public abstract partial record RequestType1Choice_
    {
    }
}
