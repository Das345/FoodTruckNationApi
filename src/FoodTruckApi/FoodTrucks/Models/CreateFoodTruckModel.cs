using System.Collections.Generic;
using AutoMapper;
using FluentValidation;
using FoodTruckNation.Core.Commands;
using FoodTruckNation.Core.Domain;

namespace FoodTruckNationApi.FoodTrucks
{
    
    /// <summary>
    /// Model class representing the data needed to create a new FoodTruck
    /// </summary>
    public class CreateFoodTruckModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFoodTruckModel"/> class.
        /// </summary>
        public CreateFoodTruckModel()
        {
            Tags = [];
        }

        /// <summary>
        /// Gets the name to give to the new Food Truck
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Gets the description of the new food truck
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets the Website of the new food truck
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets a list of tags to be attached to the new food truck.
        /// </summary>
        /// <remarks>
        /// This list is just a list of strings, so the application has to match these strings up
        /// with tag objects in the system.  Also, some tags may exist, some may not, so it is up
        /// to the application to determine this and treat each tag appropriately.
        /// </remarks>
        public List<string> Tags { get; set; }

    }


    /// <summary>
    /// Validator class for the <see cref="CreateFoodTruckModel"/> class.
    /// Ensures that the properties of the model meet the required validation rules.
    /// </summary>
    public class CreateFoodTruckModelValidator : AbstractValidator<CreateFoodTruckModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFoodTruckModelValidator"/> class.
        /// </summary>
        public CreateFoodTruckModelValidator()
        {
            RuleFor(f => f.Name)
                .NotEmpty().WithMessage("A food truck name must be provided")
                .Matches(FoodTruck.NAME_VALIDATION).WithMessage("The food truck name must be less than 40 characters and contain only letters, numbers, spaces");

            RuleFor(f => f.Description)
                .NotEmpty().WithMessage("The food truck must have a description")
                .Matches(FoodTruck.DESCRIPTION_VALIDATION).WithMessage("The description may only contain the following characters: letters, numbers, spaces, dash, period, comma and single quote");

            RuleFor(f => f.Website)
                .NotEmpty().WithMessage("The food truck must have a website")
                .Matches(FoodTruck.WEBSITE_VALIDATION).WithMessage("You must input a valid website url");

            RuleForEach(f => f.Tags)
                .NotNull().WithMessage("Tags cannot be empty")
                .Matches(Tag.TAG_TEXT_REGEX).WithMessage("Tags can only contain characters and spaces");
        }
    }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class CreateFoodTruckModelAutomapperProfile : Profile
    {
        public CreateFoodTruckModelAutomapperProfile()
        {
            CreateMap<CreateFoodTruckModel, CreateFoodTruckCommand>();
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member



}
