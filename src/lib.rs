// Common part

pub fn random_with_param(seed: f32, a: f32) -> f32 {
    let newval = (seed + a).powf(8.);
    newval - newval.trunc()
}

pub fn random(seed: f32) -> f32 {
    random_with_param(seed, 3.14159)
}
