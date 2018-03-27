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