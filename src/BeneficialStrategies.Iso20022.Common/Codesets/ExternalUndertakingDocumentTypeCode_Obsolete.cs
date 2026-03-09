// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rJUs5nCcEe2v-4Te0Ownww")]
[Description(@"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalUndertakingDocumentType2Code))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum ExternalUndertakingDocumentTypeCode_Obsolete
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// Encoded/decoded by serializers as &quot;BENS&quot;.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_rJUs53CcEe2v-4Te0Ownww")]
    [Description(@"Document is a beneficiary statement.")]
    BeneficiaryStatement,
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_rJUs6XCcEe2v-4Te0Ownww")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a claim form.
    /// Encoded/decoded by serializers as &quot;CLAF&quot;.
    /// </summary>
    [EnumMember(Value = "CLAF")]
    [IsoId("_rJUs63CcEe2v-4Te0Ownww")]
    [Description(@"Document is a claim form.")]
    ClaimForm,
    
    /// <summary>
    /// Document is an undertaking demand.
    /// Encoded/decoded by serializers as &quot;DEMD&quot;.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_rJUs6HCcEe2v-4Te0Ownww")]
    [Description(@"Document is an undertaking demand.")]
    Demand,
    
    /// <summary>
    /// Document is a transfer form.
    /// Encoded/decoded by serializers as &quot;TRAF&quot;.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_rJUs6nCcEe2v-4Te0Ownww")]
    [Description(@"Document is a transfer form.")]
    TransferForm,
    
}
