class FoodRatings {
  constructor(foods, cuisines, ratings) {
    this.foodToCuisine = new Map(); // Map from food to cuisine
    this.foodToRating = new Map(); // Map from food to rating
    this.cuisineToFoods = new Map(); // Map from cuisine to a sorted map of foods

    for (let i = 0; i < foods.length; i++) {
      const food = foods[i];
      const cuisine = cuisines[i];
      const rating = ratings[i];

      this.foodToCuisine.set(food, cuisine);
      this.foodToRating.set(food, rating);

      if (!this.cuisineToFoods.has(cuisine)) {
        this.cuisineToFoods.set(cuisine, new Map());
      }
      this.cuisineToFoods.get(cuisine).set(food, rating);
    }
  }

  changeRating(food, newRating) {
    const cuisine = this.foodToCuisine.get(food);

    // Update the food's rating
    this.foodToRating.set(food, newRating);

    // Update the cuisine's map of foods
    this.cuisineToFoods.get(cuisine).set(food, newRating);
  }

  highestRated(cuisine) {
    const cuisineFoods = this.cuisineToFoods.get(cuisine);

    let highestFood = null;
    let highestRating = -Infinity;

    for (const [food, rating] of cuisineFoods) {
      if (
        rating > highestRating ||
        (rating === highestRating && food < highestFood)
      ) {
        highestFood = food;
        highestRating = rating;
      }
    }

    return highestFood;
  }
}
