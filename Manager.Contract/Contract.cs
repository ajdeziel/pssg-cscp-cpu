﻿namespace Manager.Contract;

#region Fake MediatR

// NOTE delete this region if you end up using MediatR
public interface IRequestHandler<in TRequest, TResponse>
{
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

public interface IRequest<TResponse> { }

#endregion

public enum StateCode
{
    Active = 0,
    Inactive = 1
}

public enum StatusCode
{
    Active = 0,
    Inactive = 1
}

public enum CpuInvoiceType
{
    Deprecated = 100000002,
    OneTimePayment = 100000001,
    ScheduledPayment = 100000000,
}

public enum InvoiceType
{
    CounsCourtPsychEd = 100000000,
    DoNotUseMedicalSessions = 100000002,
    OtherPayments = 100000001,
}

public enum ProgramUnit
{
    Cpu = 100000003,
    Csu = 100000002,
    Cvap = 100000000,
    Gangs = 100000005,
    Rest = 100000004,
    Vsu = 100000001,
}

//#region Contact

//public record Contact();

//#endregion Contact

//#region Contract

//public record Contract();

//#endregion Contract


#region Currency

public record CurrencyQuery : IRequest<CurrencyResult>
{
	public string IsoCurrencyCode { get; set; }
}

public record CurrencyResult(IEnumerable<Currency> Currencies);

public record Currency(StateCode StateCode, StatusCode StatusCode, string IsoCurrencyCode);

/*
 * 			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string CurrencyName = "currencyname";
			public const string CurrencyPrecision = "currencyprecision";
			public const string CurrencySymbol = "currencysymbol";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_Url = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangerAte = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsoCurrencyCode = "isocurrencycode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string StateCodename = "statecodename";
			public const string StatusCode = "statuscode";
			public const string StatusCodename = "statuscodename";
			public const string TransactionCurrency_Contact = "TransactionCurrency_Contact";
			public const string TransactionCurrency_VSd_Contract = "TransactionCurrency_VSd_Contract";
			public const string TransactionCurrency_VSd_Program = "TransactionCurrency_VSd_Program";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string Id = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
*/

#endregion Currency