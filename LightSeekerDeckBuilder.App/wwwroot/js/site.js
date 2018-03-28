var UserPicks = {
    "hero": [],
    "combos": [],
    "actions": []
};

function getElementIcons(val) {
    var ret = "";
    console.log(val);
    val.forEach(function (element) {
        
        if (element === "Solar") {
            ret += getImage("Astral_Solar_icon.png");
        }
        else if (element === "Lunar") {
            ret += getImage("Astral_Lunar_icon.png");
        }
        else if (element === "Gravity") {
            ret += getImage("Astral_Gravity_icon.png");
        }
    });
    console.log(ret);
    return ret;
}

function getStart() {
    return "<img class=\"element-icon\" src=\"\\images\\ElementIcons\\";
}

function getEnd() {
    return "\" \\>";
}

function getImage(val) {
    return getStart() + val + getEnd();
}

/* Count Functions */

function getActionCount() {
    var actionCount = 0;
    $.each(UserPicks.actions, function (index) {
        actionCount += this.Count;
    });
    return actionCount;
}

function getHeroCount() {
    var heroCount = 0;
    $.each(UserPicks.hero, function (index) {
        heroCount += this.Count;
    });
    return heroCount;
}

function getComboCount() {
    var comboCount = 0;
    $.each(UserPicks.combos, function (index) {
        comboCount += this.Count;
    });
    return comboCount;
}

/* Card Row Functions */

function getCardRowAction(currId, currName, currCategory, currElementTypes) {
    var thisAction = {
        "Id": currId,
        "Name": currName,
        "Category": currCategory,
        "ElementTypes": currElementTypes,
        "Count": 1
    };

    var isFound = false;
    $.each(UserPicks.actions, function (index) {
        if (this.Id === thisAction.Id) {
            isFound = true;
            UserPicks.actions[index].Count += 1;
        }
    });

    if (!isFound)
        UserPicks.actions.push(thisAction);

    var newTable = "<thead><tr><td>Name</td><td>Elements</td></tr></thead><tbody>";
    $.each(UserPicks.actions, function (index) {
        newTable += '<tr class="card-row"><td>' + this.Count + ' X ' + this.Name + '</td><td>' + getElementIcons(this.ElementTypes) + '</tr>';
    });
    newTable += "</tbody>";

    return newTable;
}

function getCardRowCombo(currId, currName, currCategory, currElementTypes) {
    var thisCombo = {
        "Id": currId,
        "Name": currName,
        "Category": currCategory,
        "ElementTypes": currElementTypes,
        "Count": 1
    };

    var isFound = false;
    $.each(UserPicks.combos, function (index) {
        if (this.Id === thisCombo.Id) {
            isFound = true;
            UserPicks.combos[index].Count += 1;
        }
    });

    if (!isFound)
        UserPicks.combos.push(thisCombo);

    var newTable = "<thead><tr><td>Name</td><td>Elements</td></tr></thead><tbody>";
    $.each(UserPicks.combos, function (index) {
        newTable += '<tr class="card-row"><td>' + this.Count + ' X ' + this.Name + '</td><td>' + getElementIcons(this.ElementTypes) + '</tr>';
    });
    newTable += "</tbody>";

    return newTable;
}


function getCardRowHero(currId, currName, currCategory, currElementTypes) {
    var thisHero = {
        "Id": currId,
        "Name": currName,
        "Category": currCategory,
        "ElementTypes": currElementTypes,
        "Count": 1
    };

    var isFound = false;
    $.each(UserPicks.hero, function (index) {
        if (this.Id === thisHero.Id) {
            isFound = true;
            UserPicks.hero[index].Count += 1;
        }
    });

    if (!isFound)
        UserPicks.hero.push(thisHero);

    var newTable = "<thead><tr><td>Name</td><td>Elements</td></tr></thead><tbody>";
    $.each(UserPicks.hero, function (index) {
        newTable += '<tr class="card-row"><td>' + this.Count + ' X ' + this.Name + '</td><td>' + getElementIcons(this.ElementTypes) + '</tr>';
    });
    newTable += "</tbody>";

    return newTable;
}

