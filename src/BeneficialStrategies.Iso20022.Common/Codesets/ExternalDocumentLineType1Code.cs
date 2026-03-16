// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the document line type as published in an external document type code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Nv6E4RtqEeOa4Kl-9PmHww")]
[Description(
    @"Specifies the document line type as published in an external document type code list."
)]
[DerivedFrom(typeof(ExternalDocumentLineTypeCode))]
public enum ExternalDocumentLineType1Code
{
    /// <summary>
    /// Line item reference is an additional product identification assigned by the manufacturer.
    /// Encoded/decoded by serializers as &quot;ADPI&quot;.
    /// </summary>
    [EnumMember(Value = "ADPI")]
    [IsoId("_uSQ3vvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Line item reference is an additional product identification assigned by the manufacturer."
    )]
    AdditionalProductIdentificationAssignedByTheManufacturer =
        ExternalDocumentLineTypeCode.AdditionalProductIdentificationAssignedByTheManufacturer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an alternate International Standard Book Number (ISBN).
    /// Encoded/decoded by serializers as &quot;AISB&quot;.
    /// </summary>
    [EnumMember(Value = "AISB")]
    [IsoId("_uSaosvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an alternate International Standard Book Number (ISBN).")]
    AlternateISBN = ExternalDocumentLineTypeCode.AlternateISBN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an asset number.
    /// Encoded/decoded by serializers as &quot;ASNB&quot;.
    /// </summary>
    [EnumMember(Value = "ASNB")]
    [IsoId("_uSaotfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an asset number.")]
    AssetNumber = ExternalDocumentLineTypeCode.AssetNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a catalog number.
    /// Encoded/decoded by serializers as &quot;CTNB&quot;.
    /// </summary>
    [EnumMember(Value = "CTNB")]
    [IsoId("_uSaouPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a catalog number.")]
    CatalogNumber = ExternalDocumentLineTypeCode.CatalogNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is Dun &amp; Bradstreet Standard Product and Service code.
    /// Encoded/decoded by serializers as &quot;DBSP&quot;.
    /// </summary>
    [EnumMember(Value = "DBSP")]
    [IsoId("_uSjyovRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is Dun & Bradstreet Standard Product and Service code.")]
    DunBradstreetStandardProductAndServiceCode =
        ExternalDocumentLineTypeCode.DunBradstreetStandardProductAndServiceCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an European Article Number (EAN).
    /// Encoded/decoded by serializers as &quot;EANN&quot;.
    /// </summary>
    [EnumMember(Value = "EANN")]
    [IsoId("_uSjypfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an European Article Number (EAN).")]
    EuropeanArticleNumberEAN2551 = ExternalDocumentLineTypeCode.EuropeanArticleNumberEAN2551, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an equipment identification number.
    /// Encoded/decoded by serializers as &quot;EINB&quot;.
    /// </summary>
    [EnumMember(Value = "EINB")]
    [IsoId("_uSjyqPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an equipment identification number.")]
    EquipmentIdentificationNumber = ExternalDocumentLineTypeCode.EquipmentIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a general specification number.
    /// Encoded/decoded by serializers as &quot;GSNB&quot;.
    /// </summary>
    [EnumMember(Value = "GSNB")]
    [IsoId("_uStjovRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a general specification number.")]
    GeneralSpecificationNumber = ExternalDocumentLineTypeCode.GeneralSpecificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a Health Care Industry Bar Code (HIBC)
    /// Encoded/decoded by serializers as &quot;HIBC&quot;.
    /// </summary>
    [EnumMember(Value = "HIBC")]
    [IsoId("_uStjpfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a Health Care Industry Bar Code (HIBC)")]
    HIBCHealthCareIndustryBarCode = ExternalDocumentLineTypeCode.HIBCHealthCareIndustryBarCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an International Standard Book Number (ISBN).
    /// Encoded/decoded by serializers as &quot;ISBN&quot;.
    /// </summary>
    [EnumMember(Value = "ISBN")]
    [IsoId("_uStjqPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an International Standard Book Number (ISBN).")]
    InternationalStandardBookNumberISBN =
        ExternalDocumentLineTypeCode.InternationalStandardBookNumberISBN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a lot number.
    /// Encoded/decoded by serializers as &quot;LTNB&quot;.
    /// </summary>
    [EnumMember(Value = "LTNB")]
    [IsoId("_uS3UovRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a lot number.")]
    LotNumber = ExternalDocumentLineTypeCode.LotNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a model number
    /// Encoded/decoded by serializers as &quot;MDNB&quot;.
    /// </summary>
    [EnumMember(Value = "MDNB")]
    [IsoId("_uS3UpfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a model number")]
    ModelNumber = ExternalDocumentLineTypeCode.ModelNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a part reference number.
    /// Encoded/decoded by serializers as &quot;PRNB&quot;.
    /// </summary>
    [EnumMember(Value = "PRNB")]
    [IsoId("_uS3UqPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a part reference number.")]
    PartNumber = ExternalDocumentLineTypeCode.PartNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a product type code.
    /// Encoded/decoded by serializers as &quot;PTCD&quot;.
    /// </summary>
    [EnumMember(Value = "PTCD")]
    [IsoId("_uS3Uq_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a product type code.")]
    ProductTypeCode = ExternalDocumentLineTypeCode.ProductTypeCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a stock number.
    /// Encoded/decoded by serializers as &quot;SKNB&quot;.
    /// </summary>
    [EnumMember(Value = "SKNB")]
    [IsoId("_uS3UrvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a stock number.")]
    StockNumber = ExternalDocumentLineTypeCode.StockNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a style number.
    /// Encoded/decoded by serializers as &quot;STNB&quot;.
    /// </summary>
    [EnumMember(Value = "STNB")]
    [IsoId("_uTAekvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a style number.")]
    StyleNumber = ExternalDocumentLineTypeCode.StyleNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is a technical order number.
    /// Encoded/decoded by serializers as &quot;TONB&quot;.
    /// </summary>
    [EnumMember(Value = "TONB")]
    [IsoId("_uTAelfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a technical order number.")]
    TechnicalOrderNumber = ExternalDocumentLineTypeCode.TechnicalOrderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an UPC consumer package code.
    /// Encoded/decoded by serializers as &quot;UPCC&quot;.
    /// </summary>
    [EnumMember(Value = "UPCC")]
    [IsoId("_uTAemPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an UPC consumer package code.")]
    UPCConsumerPackageCode = ExternalDocumentLineTypeCode.UPCConsumerPackageCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item reference is an Universal Product Number.
    /// Encoded/decoded by serializers as &quot;UPNB&quot;.
    /// </summary>
    [EnumMember(Value = "UPNB")]
    [IsoId("_uTKPkvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an Universal Product Number.")]
    UniversalProductNumber = ExternalDocumentLineTypeCode.UniversalProductNumber, // same ordinal as derivation source for type conversions
}
